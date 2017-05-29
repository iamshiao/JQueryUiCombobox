using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CircleHsiao.Demo.JQueryUiCombobox.ViewModels
{
    public class JQueryUiComboboxViewModel
    {
        public IEnumerable<SelectListItem> Options { get; set; }

        public string SelectedValue { get; set; }
    }
}