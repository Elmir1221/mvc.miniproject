﻿using MiniProjectMVC.Models;

namespace MiniProjectMVC.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Models.Slider> Sliders { get; set; }
        public IEnumerable<Info> Infos { get; set; }
        public IEnumerable<About> Abouts { get; set; }
        

    }
}
