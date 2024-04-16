using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;
using Windows.Storage.Pickers;
using Windows.Storage;
using Windows.Data.Xml.Dom;
using DataTypes;
using Windows.UI.Xaml.Controls;

namespace AuditService
{
    public class Auditor
    {
        public delegate void AuditingCompleteDelegate(string message);
        public event AuditingCompleteDelegate AuditProcessingComplete;
        
        public void AuditOrder(Order order)
        {
            this.DoAuditing(order);
        }

        private async void DoAuditing(Order order)
        {
            List<OrderItem> ageRestrictedItems = FindAgeRestrictedItems(order);
            if (ageRestrictedItems.Count > 0)
            {
                try
                {
                    StorageFile file =
                        await ApplicationData.Current.LocalFolder.CreateFileAsync($"audit-{order.OrderID}.xml");
                    if (file != null)
                    {
                        XmlDocument doc = new XmlDocument();
                        XmlElement root = doc.CreateElement("Order");
                        root.SetAttribute("ID", order.OrderID.ToString());
                        root.SetAttribute("Date", order.Date.ToString());

                        foreach (OrderItem orderItem in ageRestrictedItems)
                        {
                            XmlElement itemElement = doc.CreateElement("Item");
                            itemElement.SetAttribute("Product", orderItem.Item.Name);
                            itemElement.SetAttribute("Description", orderItem.Item.Description);
                            root.AppendChild(itemElement);
                        }

                        doc.AppendChild(root);

                        await doc.SaveToFileAsync(file);
                    }
                    else
                    {
                        MessageDialog dlg =
                            new MessageDialog($"Unable to save to file: {file.DisplayName}", "Not saved");
                        _ = dlg.ShowAsync();
                    }
                }
                catch (Exception ex)
                {
                    MessageDialog dlg = new MessageDialog(ex.Message, "Exception");
                    _ = dlg.ShowAsync();
                }

                finally
                {
                    AuditProcessingComplete?.Invoke($"Audit record written for Order {order.OrderID}");
                    // if (AuditProcessingComplete is not null)
                    // {
                    //     AuditProcessingComplete($"Audit record written for Order {order.OrderID}");
                    // }
                }
            }
        }

        private List<OrderItem> FindAgeRestrictedItems(Order order)
        {
            return order.Items.FindAll(o => o.Item.AgeRestricted == true);
        }
    }
}
