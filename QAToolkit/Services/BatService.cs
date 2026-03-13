using System.Diagnostics;

namespace QAToolkit.Services
{
    public class BatService
    {
        public bool Executar(string caminhoBat)
        {
            try
            {
                ProcessStartInfo info = new ProcessStartInfo();
                info.FileName = caminhoBat;
                info.Verb = "runas";            // executa como administrador
                info.UseShellExecute = true;    // necessário para o "runas"

                Process.Start(info);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao executar BAT: {ex.Message}");
                return false;
            }
        }
    }
}