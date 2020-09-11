using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using UWP40.Models;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace UWP40
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class FriendList : Page
    {
        private List<Friend> Friends;
        public FriendList()
        {
            this.InitializeComponent();
            Friends = DataFriend.GetFriends();
        }
        private void GridView_ItemClick(object sender, ItemClickEventArgs e)
        {
            var friend = (Friend)e.ClickedItem;
            ResultTextBlock.Text = "You selected " + friend.FullName + " (" + friend.Age + ")";
        }
    }
}
