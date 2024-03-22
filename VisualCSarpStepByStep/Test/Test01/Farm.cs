using System;
using System.Collections.Generic;

namespace Test01
{
    public class Farm
    {
        public List<string> _produce;
        public List<string> _growingSeason;

        // public Farm()
        // {
        //     _produce = new List<string>();
        //     _growingSeason = new List<string>();
        // }
        
        public Farm(List<string>produce, List<string>growingSeason)
        {
            _produce = produce;
            _growingSeason = growingSeason;
        }
        
        public static void GrowUpEvent(Farm supriseEvent)
        {
            // 当土地是空的，并且使用锄头的时候，添加播种事件；
            // 当播种后，再使用洒水壶的时候，添加浇水事件；
            // 当浇水达到所需要的天数，并且进入收获季节时，添加收获事件
        }
    }
}
