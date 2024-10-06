using System;

    public class ToastOption
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public Int32 Timeout { get; set; }
        public string PositionX { get; set; }

        public string CssClass { get; set; }

        public string ToastTarget { get; set; }

        public ToastOption()
        {
            Title = string.Empty;
            Content = string.Empty;
            Timeout = 5000; // default 5 seconds
            PositionX = "Right";
            CssClass = "e-toast-info";
            ToastTarget = null;   // null for global, #toast_pos_target for the component

    }

    }

    public class ToastService
    {
        public event Action<ToastOption> ShowToastTrigger;
        public void ShowToast(ToastOption options)
        {
            //Invoke ToastComponent to update and show the toast with messages  
            if (ShowToastTrigger != null)
                ShowToastTrigger.Invoke(options);
        }
    }
