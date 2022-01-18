using HomeWork_9_Delegat;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Homework_9_Delegats
{
    public class Helper
    { // GetInvocationList как использовать пока не пойму
        // поискать примеры со вход параметрами-выписать их

        public delegate List<User> NewUsers(List<User> users);

        public List<User> SortByDescByAge(List<User> users)
        {
            Func<List<User>> sortingDelegate = () => users.OrderByDescending(x => x.Age).ToList();
            return sortingDelegate.Invoke();
        }
        public User SingleName(List<User> users, string name)
        {
            Func<User> singleUser = () => users.SingleOrDefault(x => x.Name.Equals(name));
            return singleUser.Invoke();
        }

        public int Count_Users(List<User> users)
        {            
            Func<int> user_Delegate = () => users.Count();           
            return user_Delegate.Invoke();
        }




        //public void AddToDelegate(List<User> users, int input)
        //{
        //    if(input == 1) 
        //    { 
        //    NewUsers newUsers = SortByDescByAge;
        //    }
        //    if (input == 2)
        //    {
        //    NewUsers newUsers = SingleName;
        //    }
        //    if (input == 3)
        //    {
        //        NewUsers newUsers = Count_Users;
        //    }
        //}

    }
}
