using System;

namespace DIP.Violacao
{
    /// <summary>
    /// VIOLAÇÃO DO DIP: Esta classe depende diretamente de implementações concretas.
    /// 
    /// O problema é que a classe ServicoDeNotificacao depende diretamente das classes 
    /// concretas EmailService e SMSService em vez de depender de abstrações.
    /// 
    /// Isso torna o código difícil de testar e modificar. Se quisermos adicionar um
    /// novo método de notificação (como notificações push), precisamos modificar
    /// a classe ServicoDeNotificacao diretamente.
    /// </summary>
    public class ServicoDeNotificacao
    {
        private readonly EmailService _emailService;
        private readonly SMSService _smsService;

        public ServicoDeNotificacao()
        {
            _emailService = new EmailService();
            _smsService = new SMSService();
        }

        public void NotificarCliente(Cliente cliente, string mensagem)
        {
            // Violação do DIP: Dependência direta de implementações de baixo nível
            if (cliente.CanalPreferido == "email")
            {
                _emailService.EnviarEmail(cliente.Email, mensagem);
            }
            else if (cliente.CanalPreferido == "sms")
            {
                _smsService.EnviarSMS(cliente.Telefone, mensagem);
            }
        }
    }

    public class EmailService
    {
        public void EnviarEmail(string destinatario, string mensagem)
        {
            Console.WriteLine($"Enviando e-mail para {destinatario}: {mensagem}");
            // Lógica para enviar e-mail
        }
    }

    public class SMSService
    {
        public void EnviarSMS(string numero, string mensagem)
        {
            Console.WriteLine($"Enviando SMS para {numero}: {mensagem}");
            // Lógica para enviar SMS
        }
    }

    public class Cliente
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string CanalPreferido { get; set; } // "email" ou "sms"
    }
}
