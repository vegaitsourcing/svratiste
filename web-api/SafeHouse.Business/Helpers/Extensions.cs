using System.Collections;
using System.Collections.Generic;
using SafeHouse.Data.Entities;
using SafeHouse.Data.Enums;

namespace sadfdf
{
    public static class Extensions
    {
        public IEnumerable<Meal> ToEnumList(this int source)
        {
            if ((((int)Meal.Breakfast.) & 0x01) == 1) yield return Meal.Breakfast;
            if ((((int)Meal.Lunch & 0x02) == 1) yield return Meal.Lunch;
            if ((((int)Meal.Dinner & 0x04) == 1) yield return Meal.Dinner;

                }

            }
        }
