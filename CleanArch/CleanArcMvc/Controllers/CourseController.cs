﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArch.Application.Services;
using CleanArch.Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CleanArcMvc.Controllers
{
    public class CourseController : Controller
    {
        private ICourseService _courseService; 
        
        public CourseController(ICourseService courseService)
        {
            _courseService = courseService; 
        }
        public IActionResult Index()
        {
            CourseViewModel model = _courseService.GetCourses(); 
            
            return View(model);
        }
    }
}