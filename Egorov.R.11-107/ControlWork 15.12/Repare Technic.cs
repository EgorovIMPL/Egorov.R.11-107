using System;

namespace Egorov.R._11_107.ControlWork_15._12
{
    public static class RepareTechnic
    {
        public static int KitchenRepare(this KitchenTechnic kitchenTechnic)
        {
            Random r = new Random();
            return r.Next(1,10);
        }
    }
}