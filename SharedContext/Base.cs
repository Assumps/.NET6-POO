using OO.NotificationContext;

namespace OO.SharedContext
{
    public abstract class Base : Notifiable
    {
        public Base()
        {
            // SPOF "Single point of faile" ponto unico de falha,
            // no caso o Andre explica que e interessante essa implementacao para que nao ocorra esquecimentos ou erros na hora de inseri o ID global
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
    }
}