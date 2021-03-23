using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using TestOrder1.Infrastructure.Commnds.Base;

namespace TestOrder1.Infrastructure.Commnds
{
    class CloseDialogCommand : Command
    {
        public bool? DialogResult { get; set; }
        protected override bool CanExecute(object p) => p is Window;

        protected override void Execute(object p)
        {
            if (!CanExecute(p)) return;
            var window = (Window)p;
            window.DialogResult = DialogResult;
            window.Close();
        }
    }
}
