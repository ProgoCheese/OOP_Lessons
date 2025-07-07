using System;
using System.Text;

namespace RangeTask
{
    class MyRange
    {
        private int from;
        private int to;

        public void InputRange(int from, int to)
        {
            this.from = from;
            this.to = to;
        }

        public int GetLengthRange()
        {
            return to - from + 1;
        }

        public bool IsInside(int number)
        {
            if (number >= from && number <= to) return true;

            return false;
        }

        /// <summary>
        /// Пересечение 2 интервалов
        /// </summary>
        /// <param name="firstRange"></param>
        /// <param name="secondRange"></param>
        /// <returns></returns>
        public MyRange GetIntersectionRange(MyRange firstRange, MyRange secondRange)
        {
            MyRange range = new MyRange();

            if (firstRange.from <= secondRange.from && secondRange.from <= firstRange.to)
            {
                range.from = secondRange.from;

                if (firstRange.to <= secondRange.to)
                {
                    range.to = firstRange.to;
                }
                else
                {
                    range.to = secondRange.to;
                }
            }
            else if (firstRange.from >= secondRange.from && secondRange.to >= firstRange.from)
            {
                range.from = firstRange.from;

                if (firstRange.to <= secondRange.to)
                {
                    range.to = firstRange.to;
                }
                else
                {
                    range.to = secondRange.to;
                }
            }

            if (range.GetLengthRange != null)
            {
                return range;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Объединение интервалов 
        /// </summary>
        /// <param name="firstRange"></param>
        /// <param name="secondRange"></param>
        /// <returns></returns>
        public MyRange[] CombiningTwoIntervals(MyRange firstRange, MyRange secondRange)
        {
            MyRange range = new MyRange();

            if (firstRange.from <= secondRange.from && secondRange.from <= firstRange.to)
            {
                range.from = firstRange.from;

                if (firstRange.to <= secondRange.to)
                {
                    range.to = secondRange.to;
                }
                else
                {
                    range.to = firstRange.to;
                }
            }
            else if (firstRange.from >= secondRange.from && secondRange.to >= firstRange.from)
            {
                range.from = firstRange.from;

                if (firstRange.to >= secondRange.to)
                {
                    range.to = firstRange.to;
                }
                else
                {
                    range.to = secondRange.to;
                }
            }

            if (range.GetLengthRange != null)
            {
                MyRange[] intervals = [range];
                return intervals;
            }
            else
            {
                MyRange[] intervals = [firstRange, secondRange];
                return intervals;
            }
        }

        /// <summary>
        /// Разность первого из второго
        /// </summary>
        /// <param name="firstRange"></param>
        /// <param name="secondRange"></param>
        /// <returns></returns>
        public MyRange[] GetDifferenceIntervals(MyRange firstRange, MyRange secondRange)
        {
            MyRange firstRemainderRange = new MyRange();
            MyRange secondRemainderRange = new MyRange();

            if (firstRange.from <= secondRange.from && secondRange.from <= firstRange.to)
            {
                if (firstRange.to <= secondRange.to)
                {
                    firstRemainderRange.from = firstRange.from;
                    firstRemainderRange.to = secondRange.from;
                    MyRange[] intervals = [firstRemainderRange];
                    return intervals;
                }
                else
                {
                    firstRemainderRange.from = firstRange.from;
                    firstRemainderRange.to = secondRange.from;
                    secondRemainderRange.to = firstRange.to;
                    secondRemainderRange.from = secondRange.to;
                    MyRange[] intervals = [firstRemainderRange, secondRemainderRange];
                    return intervals;
                }
            }
            else if (firstRange.from >= secondRange.from && secondRange.to >= firstRange.from)
            {
                if (firstRange.to >= secondRange.to)
                {
                    firstRemainderRange.from = firstRange.to;
                    firstRemainderRange.to = secondRange.to;
                    MyRange[] intervals = [firstRemainderRange];
                    return intervals;
                }
                else
                {
                    firstRemainderRange.from = 0;
                    firstRemainderRange.to = 0;
                    MyRange[] intervals = [firstRemainderRange];
                    return intervals;
                }
            }
            else
            {
                MyRange[] intervals = [firstRange];
                return intervals;
            }
        }
    }

    class Programm
    {
        private static void Main()
        {
            Console.WriteLine("Введите начало диапозона");
            int from = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите конец диапозона");
            int to = Convert.ToInt32(Console.ReadLine());

            MyRange range = new MyRange();
            range.InputRange(from, to);

            Console.WriteLine("Длина: " + range.GetLengthRange());

            Console.WriteLine("Введите число");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Оно в диапозоне? " + range.IsInside(number));
        }
    }
}