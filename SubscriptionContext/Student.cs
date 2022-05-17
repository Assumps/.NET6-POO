using OO.NotificationContext;
using OO.SharedContext;

namespace OO.SubscriptionContext
{
    public class Student : Base
    {
        public Student()
        {
            Subscriptions = new List<Subscription>();
        }
        public string Name { get; set; }
        public string Email { get; set; }
        public User User { get; set; }
        public IList<Subscription> Subscriptions { get; set; }

        public void CreateSubscription(Subscription subs){
            if(IsPremium){
                AddNotification(new Notification("Premium","Aluno ja e assinante"));
                return;
            }

            Subscriptions.Add(subs);
        }
        public bool IsPremium => Subscriptions.Any(x => !x.IsInactive);
    }
}