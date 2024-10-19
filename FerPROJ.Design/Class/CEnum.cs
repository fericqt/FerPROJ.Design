﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerPROJ.Design.Class
{
    public class CEnum
    {
        public enum AllowedOpenDB
        {
            One,
            Two
        }
        public enum BankType
        {
            VISA,
            DEBIT,
            CREDIT,
            PREPAID
        }
        public enum UserLevelSchool
        {
            Administrator,
            Teacher
        }
        public enum Sort {
            DESC,
            ASC
        }
        public enum Status {
            ACTIVE,
            CANCELLED
        }
    }
}
