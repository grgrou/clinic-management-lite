﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using BE;
using System.Data;
using System.Data.SqlClient;
using General;

namespace ClinicManagementLite
{
    class FormPermission : FormController
    {
        public void actionDelete(Form ctx)
        {
            FormList form = (FormList)ctx;

            int id = int.Parse(form.dgvList.CurrentRow.Cells[0].Value.ToString());
            CMPermissionBL.delete(new CMPermissionBE(id));
        }

        public void actionInsert(Form ctx)
        {
            FormMaintenance01 form = (FormMaintenance01)ctx;
            CMPermissionBL.create(new CMPermissionBE(form.txtDescription.Text));
        }

        public void actionUpdate(Form ctx)
        {
            FormMaintenance01 form = (FormMaintenance01)ctx;
            CMPermissionBL.update(new CMPermissionBE(form.instanceID, form.txtDescription.Text));
        }

        public void setupFormList(Form ctx)
        {
            FormList form = (FormList)ctx;

            DataTable dtList = CMPermissionBL.getAll();

            form.Text = "Mantenimiento - Permiso";
            form.lblTitle.Text = $"Permisos - ({dtList.Rows.Count})";

            form.dgvList.DataSource = dtList;
        }

        public void setupFormMaintenance(Form ctx)
        {
            FormMaintenance01 form = (FormMaintenance01)ctx;

            form.Text = form.isEditing ? "Actualizar Permiso" : "Insertar Permiso";
            form.btnAction.Text = form.isEditing ? "Actualizar" : "Insertar";
            form.gbPermission.Enabled = true;

            if (form.isEditing)
            {
                try
                {
                    CMPermissionBE permission = CMPermissionBL.get(new CMPermissionBE(form.instanceID));
                    form.txtDescription.Text = permission.permission_description;
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message); // TODO: - Fix
                }
            }
        }

    }
}
