﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using General;

namespace BE
{
    public class CMClientBE : CMPersonBE
    {
        public string client_weight         = "";
        public string client_height         = "";
        public string client_bloodType      = "";
        public string client_bloodPressure  = "";
        public string client_allergies      = "";
        public string client_pathologies    = "";
        public string client_medicines      = "";
        public string client_seizures       = "";
        public string client_diabetes       = "";
        public string client_cholesterol    = "";
        public string client_cancer         = "";
        public string client_aids           = "";
        public DateTime client_createdAt    = new DateTime();

        public CMClientBE(SqlDataReader reader)
        {
            this.person_dni             = reader["person_id"].ToString();
            this.person_name            = reader["person_name"].ToString();
            this.person_lastname        = reader["person_lastname"].ToString();
            this.person_phone           = reader["person_phone"].ToString();
            this.person_birthday        = Convert.ToDateTime(reader["person_birthday"].ToString());
            this.person_address         = reader["person_address"].ToString();
            this.person_gender          = Convert.ToInt16(reader["person_gender"].ToString());
            this.person_image           = reader["person_image"].ToString();
            this.person_createdAt       = Convert.ToDateTime(reader["person_created_at"].ToString());
            this.client_weight          = reader["client_wheight"].ToString();
            this.client_height          = reader["client_height"].ToString();
            this.client_bloodType       = reader["client_blood_type"].ToString();
            this.client_bloodPressure   = reader["client_blood_pressure"].ToString();
            this.client_allergies       = reader["client_allergies"].ToString();
            this.client_pathologies     = reader["client_pathologies"].ToString();
            this.client_medicines       = reader["client_medicines"].ToString();
            this.client_seizures        = reader["client_seizures"].ToString();
            this.client_diabetes        = reader["client_diabetes"].ToString();
            this.client_cholesterol     = reader["client_cholesterol"].ToString();
            this.client_cancer          = reader["client_cancer"].ToString();
            this.client_aids            = reader["client_aids"].ToString();
            this.client_createdAt       = Convert.ToDateTime(reader["client_created_at"].ToString());
        }
    }
}
