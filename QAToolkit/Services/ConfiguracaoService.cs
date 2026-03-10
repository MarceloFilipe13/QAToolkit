using Newtonsoft.Json;
using QAToolkit.Models;

namespace QAToolkit.Services
{
    public class ConfiguracaoService
    {
        // Caminho do arquivo JSON — fica na mesma pasta do executável
        private readonly string _caminhoArquivo = "processos.json";

        // Carrega a lista do arquivo JSON
        public List<ProcessoItem> CarregarProcessos()
        {
            try
            {
                if (!File.Exists(_caminhoArquivo))
                    return new List<ProcessoItem>();

                string json = File.ReadAllText(_caminhoArquivo);
                return JsonConvert.DeserializeObject<List<ProcessoItem>>(json)
                       ?? new List<ProcessoItem>();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar configurações: {ex.Message}");
                return new List<ProcessoItem>();
            }
        }

        // Salva a lista no arquivo JSON
        public void SalvarProcessos(List<ProcessoItem> processos)
        {
            try
            {
                string json = JsonConvert.SerializeObject(processos, Formatting.Indented);
                File.WriteAllText(_caminhoArquivo, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar configurações: {ex.Message}");
            }
        }
    }
}