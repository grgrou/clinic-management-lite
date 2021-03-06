﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using General;

namespace BE
{
    public class CMEmployeeBE : CMPersonBE
    {
        public CMPositionBE employee_position { get; set; } = new CMPositionBE();

        public Single employee_salary { get; set; } = 0;
        public DateTime employee_createdAt { get; set; } = new DateTime();

        public string employee_nameAndDni
        {
            get
            {
                return $"{person_dni} - {person_lastname}";
            }
        }

        public CMEmployeeBE() { }

        public CMEmployeeBE(SqlDataReader reader)
        {
            this.person_dni         = reader["person_id"].ToString();
            this.person_name        = reader["person_name"].ToString();
            this.person_lastname    = reader["person_lastname"].ToString();
            this.person_phone       = reader["person_phone"].ToString();
            this.person_birthday    = Convert.ToDateTime(reader["person_birthday"].ToString());
            this.person_address     = reader["person_address"].ToString();
            this.person_gender      = Convert.ToInt16(reader["person_gender"].ToString());
            this.person_image       = reader["person_image"].ToString();
            this.person_createdAt   = Convert.ToDateTime(reader["person_created_at"].ToString());
            this.employee_salary    = Convert.ToSingle(reader["employee_salary"]);
            this.employee_position  = new CMPositionBE(reader);
            this.employee_createdAt = Convert.ToDateTime(reader["employee_created_at"]);
        }
    }
}
