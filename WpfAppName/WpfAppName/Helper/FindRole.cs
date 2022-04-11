using System.Windows;
using WpfAppName.Model;
using WpfAppName.ViewModel;
namespace WpfAppName.Helper
{
    public class FindRole
    {
        int id;
        public FindRole(int id)
        {
            this.id = id;
        }
        public bool RolePredicate(Role role)
        {
            return role.Id == id;
        }
    }
}