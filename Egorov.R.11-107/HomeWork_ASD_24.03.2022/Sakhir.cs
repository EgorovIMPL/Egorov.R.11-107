using System;

namespace Egorov.R._11_107
{
    public class Sakhir
    {
        public int Run(int[,] array) 
        {
            //исходные данные
            var building = GetBuilding(array);
            int floorCount = building.GetLength(0);
            int roomCount = building.GetLength(1) - 2;
            /*1) выходим с левой лестницы и возвращаемся в левую лестницу
              2) выходим с левой лестницы, переходим в правую лестницу
              3) выходим с правой лестницы, возвращаемся в правую лестницу
              4) выходим с правой лестницы, переходим в левую лестницу 
            */
            //матрица для шагов дп
            var dp = new int[floorCount, 4];

            for (int i = 0; i < floorCount; i++)
                CalcFloor(i, floorCount, roomCount, building, ref dp);

            Console.WriteLine($"Количество минут " +
                $"{Math.Min(dp[floorCount - 1,0], dp[floorCount - 1,2])}");
            return Math.Min(dp[floorCount - 1,0], dp[floorCount - 1,2]);
        }
        /// <summary>
        /// Считаем количество минут для одного этажа
        /// </summary>
        /// <param name="floor">текущий номер этажа</param>
        /// <param name="building">матрица здания</param>
        /// <param name="dp">матрица для ДП</param>
        private void CalcFloor(int floor, int floorCount,
            int roomCount, int[,] building, ref int[,] dp)
        {
            //находим самую левую комнату с вкл светом
            int mostLeftRoomWithLight = 0;
            //самая правая комната с вкл светом
            int mostRightRoomWithLight = roomCount + 1;
            GetMostLeftRight(floor, roomCount, building,
                ref mostLeftRoomWithLight, ref mostRightRoomWithLight);


            //общий случай (не первый и не последний этажи) 
            if (floor > 0 && floor < floorCount - 1)
            {
                //выходим с левой лестницы и возвращаемся в левую лестницу
                dp[floor, 0] =
                    //стоимость дойти до floor - 1 этажа
                    Math.Min(dp[floor - 1, 0], dp[floor - 1, 3]) +
                    //стоимость подъема на этаж
                    1 +
                    //стоимость дойти до последней комнаты 
                    //с вкл светом и обратно
                    mostRightRoomWithLight + mostRightRoomWithLight;

                //выходим с левой лестницы, переходим в правую лестницу
                dp[floor, 1] =
                    //стоимость дойти до floor - 1 этажа
                    Math.Min(dp[floor - 1, 0], dp[floor - 1, 3]) +
                    //стоимость подъема на этаж
                    1 +
                    //стоимость пройти весь этаж
                    roomCount + 1;

                //выходим с правой лестницы, возвращаемся в правую лестницу
                dp[floor, 2] =
                    //стоимость дойти до floor - 1 этажа
                    Math.Min(dp[floor - 1, 1], dp[floor - 1, 2]) +
                    //стоимость подъема на этаж
                    1 +
                    //стоимость дойти до самой левой комнаты со светом и обратно
                    //= 1(стоимость перейти с лестницы на этаж)
                    // + количество шагов до самой левой комнаты 
                    (1 + roomCount - mostLeftRoomWithLight) * 2;

                //выходим с правой лестницы, переходим в левую лестницу 
                dp[floor, 3] =
                    //стоимость дойти до floor - 1 этажа
                    Math.Min(dp[floor - 1, 1], dp[floor - 1, 2]) +
                    //стоимость подъема на этаж
                    1 +
                    //пройти по всему этажу
                    roomCount + 1;
            }
            //первый этаж
            else if (floor == 0)
            {
                //выходим с левой лестницы и возвращаемся в левую лестницу
                dp[0, 0] = mostRightRoomWithLight * 2;
                //выходим с левой лестницы, переходим в правую лестницу
                dp[0, 1] = roomCount + 1;


                //начинаем всегда с левой лестницы, 
                //поэтому выход с правой помечаем 
                //как Int32.MaxValue
                dp[0, 2] = Int32.MaxValue;
                dp[0, 3] = Int32.MaxValue;
            }
            else if (floor == floorCount - 1)
            {
                dp[floor, 0] = Math.Min(dp[floor - 1, 0], dp[floor - 1, 3]) + 1 + mostRightRoomWithLight;
                dp[floor, 1] = Math.Min(dp[floor - 1, 0], dp[floor - 1, 3]) + 1 + mostRightRoomWithLight;
                dp[floor, 2] = Math.Min(dp[floor - 1, 1], dp[floor - 1, 2]) + 1 + (1 + roomCount - mostLeftRoomWithLight);
                dp[floor, 3] = Math.Min(dp[floor - 1, 1], dp[floor - 1, 2]) + 1 + (1 + roomCount - mostLeftRoomWithLight);
            }

        }

        /// <summary>
        /// Самая левая и самая правая комната с включенным светом на этаже 
        /// </summary>
        private void GetMostLeftRight(int floor, int roomCount, int[,] building,
            ref int mostLeftRoomWithLight, ref int mostRightRoomWithLight)
        {
            for (int i = 1; i <= roomCount; i++)
            {
                if (building[floor, i] == 1)
                {
                    if (mostLeftRoomWithLight == 0)
                        mostLeftRoomWithLight = i;
                    mostRightRoomWithLight = i;
                }
            }
        }

        private int[,] GetBuilding(int[,] array)
        {
            return array;
        }
    }
}