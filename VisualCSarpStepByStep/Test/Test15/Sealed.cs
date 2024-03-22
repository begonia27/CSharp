namespace Test15;

class Food
{
    
}

internal interface IVegetable
{
    
}

sealed class Fruit: Food, IVegetable
{
    
}

// Cannot inherit from sealed class 'Fruit'
// class apple: Fruit
// {
//     
// }
