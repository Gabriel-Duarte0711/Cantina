using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace cantinaPainel
{
    internal class PersistenciaEstoque
    {
        
        public static List<Estoque> estoqueGeral = new List<Estoque>();
        private static string caminho = @"C:\Temp\pedidos.json";
        public static void InicializarEstoque()
        {
            estoqueGeral.Clear();

            foreach (var produto in PersistenciaProduto.itemEstoque)
            {
                Estoque novoEstoque = new Estoque
                {
                    Produto = produto,
                    Quantidade = 0
                };

                estoqueGeral.Add(novoEstoque);
            }
        }

        public static void saveToFile()
        {
            try
            {
                string json = JsonConvert.SerializeObject(estoqueGeral, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText(caminho, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void LoadListFromFile()
        {
            try
            {
                if (File.Exists(caminho))
                {
                    string json = File.ReadAllText(caminho);
                    if (!string.IsNullOrEmpty(json))
                    {
                        var estoqueCarregado = JsonConvert.DeserializeObject<List<Estoque>>(json);

                        // ✅ VALIDAR SE OS PRODUTOS ESTÃO OK
                        if (estoqueCarregado != null)
                        {
                            estoqueGeral.Clear();
                            foreach (var estoque in estoqueCarregado)
                            {
                                // Verificar se o produto existe
                                if (estoque.Produto != null)
                                {
                                    estoqueGeral.Add(estoque);
                                }
                                else
                                {
                                    // Recriar o produto se estiver null
                                    var produtoOriginal = PersistenciaProduto.itemEstoque
                                        .FirstOrDefault(p => p.Codigo == estoque.Produto?.Codigo);

                                    if (produtoOriginal != null)
                                    {
                                        estoque.Produto = produtoOriginal;
                                        estoqueGeral.Add(estoque);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // ✅ INICIALIZAR SE DEU ERRO
                InicializarEstoque();
            }

        }
        public static void LimparArquivoEstoque()
        {
            try
            {
                File.WriteAllText(caminho, string.Empty);
                estoqueGeral.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao limpar o arquivo: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
