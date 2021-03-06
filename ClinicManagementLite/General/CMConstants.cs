﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General
{
    public struct CMProcedure
    {
        public struct Account
        {
            public static string create  = "usp_accountCreate";
            public static string delete  = "usp_accountDelete";
            public static string get     = "usp_accountGet";
            public static string getAll  = "usp_accountGetAll";
            public static string login   = "usp_accountLogin";
            public static string update  = "usp_accountUpdate";
        }
        public struct Area
        {
            public static string create = "usp_areaCreate";
            public static string delete = "usp_areaDelete";
            public static string get    = "usp_areaGet";
            public static string getAll = "usp_areaGetAll";
            public static string update = "usp_areaUpdate";
            public static string areaSalary = "usp_areaWithSalary";
        }
        public struct Client
        {
            public static string create = "usp_clientCreate";
            public static string delete = "usp_clientDelete";
            public static string get    = "usp_clientGet";
            public static string getAll = "usp_clientGetAll";
            public static string update = "usp_clientUpdate";
        }
        public struct Employee
        {
            public static string create = "usp_employeeCreate";
            public static string delete = "usp_employeeDelete";
            public static string get    = "usp_employeeGet";
            public static string getAll = "usp_employeeGetAll";
            public static string update = "usp_employeeUpdate";
        }
        public struct Permission
        {
            public static string create = "usp_permissionCreate";
            public static string delete = "usp_permissionDelete";
            public static string get    = "usp_permissionGet";
            public static string getAll = "usp_permissionGetAll";
            public static string update = "usp_permissionUpdate";
        }
        public struct Person
        {
            public static string create = "usp_personCreate";
            public static string getAll = "usp_personGetAll";
            public static string update = "usp_personUpdate";
        }
        public struct Position
        {
            public static string create  = "usp_positionCreate";
            public static string delete  = "usp_positionDelete";
            public static string get     = "usp_positionGet";
            public static string getAll  = "usp_positionGetAll";
            public static string update  = "usp_positionUpdate";
        }
        public struct Schedule
        {
            public static string create             = "usp_scheduleCreate";
            public static string delete             = "usp_scheduleDelete";
            public static string filterByDay        = "usp_scheduleFilterByDay";
            public static string filterByEmployee   = "usp_scheduleFilterByEmployee";
            public static string filterByTurn       = "usp_scheduleFilterByTurn";
            public static string getAll             = "usp_scheduleGetAll";
        }
        public struct Turn
        {
            public static string create = "usp_turnCreate";
            public static string delete = "usp_turnDelete";
            public static string get    = "usp_turnGet";
            public static string getAll = "usp_turnGetAll";
            public static string update = "usp_turnUpdate";
        }
    }

    public struct CMMessage
    {
        public struct Alert
        {
            public static string title                  = "Clinic Management Lite";
            public static string titleError             = "Clinic Management Lite";
        }

        public struct Session
        {
            public static string logout                 = "Seguro que desea cerrar sesion?";
        }

        public struct Maintenance
        {
            public static string deleteInstance         = "Seguro que desea eliminar este registro?";
            public static string notFoundInstance       = "No se encontro registro en nuestra base de datos.";
        }

        public struct Account
        {
            public static string accountNotFound        = "La cuenta ingresada no esta registrada en nuestra base de datos.";
            public static string usernameMinString      = "El usuario debe tener como minimo 5 digitos.";
            public static string passwordMinString      = "La contrasena debe tener como minimo 6 digitos.";
        }

        public struct Person
        {
            public static string dniMinString           = "El DNI debe tener 8 digitos.";
            public static string nameEmptyString        = "Ingrese un nombre valido.";
            public static string lastNameEmptyString    = "Ingrese un apellido valido.";
            public static string phoneEmptyString       = "Ingrese un numero de celular valido.";
            public static string addressEmptyString     = "Ingrese una direccion valida.";
            public static string salaryMinimun          = "Ingrese un sueldo mayor a 850.";
        }

        public struct Form
        {
            public static string descriptionEmpty       = "Ingrese una descripcion valida.";
        }

        public struct Error
        {
            public static string uniqueKey              = "No se pudo completar la operacion. Uno o mas campos ingresados ya existen en nuestra base de datos.";
            public static string deleteKey              = "No se pudo completar la operacion. Este registro esta asociado a otro.";
        }
    }
}
