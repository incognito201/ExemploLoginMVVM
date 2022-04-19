using Microsoft.Xaml.Behaviors;
using System.Linq;
using System.Security;
using System.Windows;
using System.Windows.Controls;

namespace ExemploLoginMVVM.WPF.Behavior
{
    public class PasswordBoxBehavior : Behavior<PasswordBox>
    {
        protected override void OnAttached()
        {
            AssociatedObject.LostFocus += OnComparePasswordLostFocus;
            base.OnAttached();
        }

        protected override void OnDetaching()
        {
            AssociatedObject.LostFocus -= OnComparePasswordLostFocus;
            base.OnDetaching();
        }

        public static readonly DependencyProperty PasswordProperty =
            DependencyProperty.Register("Password", typeof(SecureString), typeof(PasswordBoxBehavior), new FrameworkPropertyMetadata(null) { BindsTwoWayByDefault = true });


        public SecureString Password
        {
            get { return (SecureString)GetValue(PasswordProperty); }
            set { SetValue(PasswordProperty, value); }
        }

        private static void OnComparePasswordLostFocus(object sender, RoutedEventArgs e)
        {
            PasswordBox pswdBox = sender as PasswordBox;
            PasswordBoxBehavior behavior = Interaction.GetBehaviors(pswdBox).OfType<PasswordBoxBehavior>().FirstOrDefault();
            if (behavior != null)
            {
                behavior.Password = pswdBox.SecurePassword;
            }
        }
    }
}
