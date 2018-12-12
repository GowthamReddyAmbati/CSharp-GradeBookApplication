using System;
using GradeBook.Enums;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook:BaseGradeBook
    {
        public RankedGradeBook(String name):base(name)
        {
            Type = GradeBookType.Ranked;
        }
    }
}
