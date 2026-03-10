using System.Diagnostics;

namespace QAToolkit.Services
{
    public class GerenciadorProcessos
    {
        // Abre um executável como administrador
        public bool AbrirProcesso(string caminhoExe)
        {
            try
            {
                ProcessStartInfo info = new ProcessStartInfo();
                info.FileName = caminhoExe;
                info.Verb = "runas";        // "runas" = executar como admin
                info.UseShellExecute = true;

                Process.Start(info);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao abrir processo: {ex.Message}");
                return false;
            }
        }

        // Fecha todos os processos com o nome informado
        public bool FecharProcesso(string nomeProcesso)
        {
            try
            {
                // Busca todos os processos com esse nome rodando no Windows
                Process[] processos = Process.GetProcessesByName(nomeProcesso);

                if (processos.Length == 0)
                {
                    MessageBox.Show($"Nenhum processo '{nomeProcesso}' encontrado.");
                    return false;
                }

                foreach (Process p in processos)
                {
                    p.Kill();
                    p.WaitForExit(); // aguarda encerrar completamente
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao fechar processo: {ex.Message}");
                return false;
            }
        }

        // Verifica se um processo está rodando
        public bool ProcessoEstaRodando(string nomeProcesso)
        {
            Process[] processos = Process.GetProcessesByName(nomeProcesso);
            return processos.Length > 0;
        }
    }
}