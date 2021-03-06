﻿using KuasCore.Models;
using KuasCore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyWebApp.Controllers
{
    public class EmployeeController : ApiController
    {
        public IEmployeeService EmployeeService { get; set; }

        [HttpGet]
        public IList<Employee> GetAllEmployees()
        {
            return EmployeeService.GetAllEmployees();
        }

        [HttpGet]
        [ActionName("byId")]
        public Employee GetEmployeeById(string id)
        {
            return EmployeeService.GetEmployeeById(id);
        }

        [HttpGet]
        [ActionName("byName")]//因為有兩個方法...參數都一樣STRING指定actionName查詢時多一層/ 為了辨別
        public Employee GetEmployeeByName(string name)
        {
            return EmployeeService.GetEmployeeByName(name);
        }
    }
}