using System;
using System.Collections.Generic;

namespace campanhabrinquedo.Application.ViewModel
{
    public class ViewModelBase
    {
        public Guid Id { get; set; }
        public bool IsValid => Errors != null ? Errors.Count > 0 : true;
        public IList<string> Errors { get; set; }

        public ViewModelBase()
        {
            Errors = new List<string>();
        }
    }
}
