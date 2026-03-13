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

        // Caminho do arquivo JSON dos BATs
        private readonly string _caminhoArquivoBat = "bats.json";

        public List<BatItem> CarregarBats()
        {
            try
            {
                // Verifica se o arquivo existe — na primeira vez não vai existir
                // e retorna uma lista vazia em vez de dar erro
                if (!File.Exists(_caminhoArquivoBat))
                    return new List<BatItem>();

                string json = File.ReadAllText(_caminhoArquivoBat);

                // Converte o JSON de volta para uma lista de objetos BatItem
                return JsonConvert.DeserializeObject<List<BatItem>>(json)
                       ?? new List<BatItem>();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar BATs: {ex.Message}");
                return new List<BatItem>();
            }
        }

        public void SalvarBats(List<BatItem> bats)
        {
            try
            {
                // Converte a lista de objetos para JSON formatado
                // Formatting.Indented deixa o JSON organizado e legível
                string json = JsonConvert.SerializeObject(bats, Formatting.Indented);
                File.WriteAllText(_caminhoArquivoBat, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar BATs: {ex.Message}");
            }
        }
    }
}