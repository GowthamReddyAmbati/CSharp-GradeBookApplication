﻿using System;
using GradeBook.Enums;
using System.Collections.Generic;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook:BaseGradeBook
    {
        public StandardGradeBook(string Name, bool isWeighted):base(Name,isWeighted)
        {
            Type = GradeBookType.Standard;
        }
    }
}
