﻿using LeitorFiscal.LeituraArquivo;
using LeitorFiscal.Model.Util;
using System.ComponentModel.DataAnnotations;

namespace LeitorFiscal.AFD;

public class TrailerAFD1510
{
    [MaxLength(9, ErrorMessage = "O campo Noves deve ter um comprimento máximo de '9'")]
    [MinLength(9, ErrorMessage = "O campo Noves deve ter um comprimento minimo de '9'")]
    public string? Noves { get; private set; } /*Tamanho: 9, Posição: 1 a 9, Tipo: numérico, Dado: = 999999999*/

    [MaxLength(9, ErrorMessage = "O campo QtdRegTipo2 deve ter um comprimento máximo de '9'")]
    [MinLength(9, ErrorMessage = "O campo QtdRegTipo2 deve ter um comprimento minimo de '9'")]
    public string? QtdRegTipo2 { get; private set; } /*Tamanho: 9, Posição: 10 a 18, Tipo: numérico*/

    [MaxLength(9, ErrorMessage = "O campo QtdRegTipo3 deve ter um comprimento máximo de '9'")]
    [MinLength(9, ErrorMessage = "O campo QtdRegTipo3 deve ter um comprimento minimo de '9'")]
    public string? QtdRegTipo3 { get; private set; } /*Tamanho: 9, Posição: 19 a 27, Tipo: numérico*/

    [MaxLength(9, ErrorMessage = "O campo QtdRegTipo4 deve ter um comprimento máximo de '9'")]
    [MinLength(9, ErrorMessage = "O campo QtdRegTipo4 deve ter um comprimento minimo de '9'")]
    public string? QtdRegTipo4 { get; private set; } /*Tamanho: 9, Posição: 28 a 36, Tipo: numérico*/

    [MaxLength(9, ErrorMessage = "O campo QtdRegTipo5 deve ter um comprimento máximo de '9'")]
    [MinLength(9, ErrorMessage = "O campo QtdRegTipo5 deve ter um comprimento minimo de '9'")]
    public string? QtdRegTipo5 { get; private set; } /*Tamanho: 9, Posição: 37 a 45, Tipo: numérico*/

    [MaxLength(1, ErrorMessage = "O campo TpRegistro deve ter um comprimento máximo de '1'")]
    [MinLength(1, ErrorMessage = "O campo TpRegistro deve ter um comprimento minimo de '1'")]
    public string? TpRegistro { get; private set; } /*Tamanho: 1, Posição 46 a 46, Tipo: numérico, Dado: = 9*/

    public static List<TrailerAFD1510> TrailerAfdList { get; private set; } = new();
    public static List<string> ErrosValidacao { get; private set; } = new();
    public static string? Portaria { get; set; } = string.Empty;
    #region Funções
    public static void GetTrailer(string linhaArquivo)
    {
        TrailerAFD1510 trailer;
        int tamanhoLinha = linhaArquivo.Length;
        if (tamanhoLinha != 46)
        {
            ErrosValidacao.Add($"O registro de '9 - Trailer' possui o tamanho de caracteres diferentes que o definido pela a Portaria n.º 1510, de 21 de agosto de 2013. Tamanho encotrado {tamanhoLinha}\n");
            return;
        }
        else
        {
            Portaria = "Portaria n.º 1510, de 21 de agosto de 2013\n";

            trailer = new()
            {
                Noves = linhaArquivo[..9].Trim(),
                QtdRegTipo2 = linhaArquivo.Substring(9, 9).Trim(),
                QtdRegTipo3 = linhaArquivo.Substring(18, 9).Trim(),
                QtdRegTipo4 = linhaArquivo.Substring(27, 9).Trim(),
                QtdRegTipo5 = linhaArquivo.Substring(36, 9).Trim(),
                TpRegistro = linhaArquivo.Substring(45, 1).Trim()
            };
        }


        if (ValidacaoTamanhoDado.ValidarTamanho(trailer, linhaArquivo) && ValidarTipoDados(trailer, linhaArquivo))
        {
            if (trailer.TpRegistro != "9")
            {
                ErrosValidacao.Add($"O campo 'TpRegistro' esta com o valor ({trailer.TpRegistro}) inválido, deve ter o valor '9'.\n\tLinha ({LerArquivoAFD.NumeroLinha}): {linhaArquivo}\n");
                return;
            }

            if (trailer.Noves != "999999999")
            {
                ErrosValidacao.Add($"O campo 'Noves' esta com o valor ({trailer.Noves}) inválido, deve ter o valor '999999999'.\n\tLinha ({LerArquivoAFD.NumeroLinha}): {linhaArquivo}\n");
                return;
            }

            TrailerAfdList.Add(trailer);
        }
        foreach (var item in ValidacaoTamanhoDado.ErrosValidacao)
        {
            ErrosValidacao.Add(item + "\n");
        }

    }
    public static bool ValidarResgistrosAEJ(int reg02, int reg03, int reg04, int reg05)
    {
        int count = 0;
        foreach (var item in TrailerAfdList)
        {
            if (int.Parse(item.QtdRegTipo2!) != reg02)
            {
                ErrosValidacao.Add($"Quantidade de registros '2 - Identificação Empresa' inválido, quantidade verificada: {reg02}, quantidade no registro 9 - Trailer: {item.QtdRegTipo2}\n");
                count++;
            }
            if (int.Parse(item.QtdRegTipo3!) != reg03)
            {
                ErrosValidacao.Add($"Quantidade de registros '3 - Marcação do Ponto' inválido, quantidade verificada: {reg03}, quantidade no registro 9 - Trailer: {item.QtdRegTipo3}\n");
                count++;
            }
            if (int.Parse(item.QtdRegTipo4!) != reg04)
            {
                ErrosValidacao.Add($"Quantidade de registros '4 - Tempo Real' inválido, quantidade verificada: {reg04}, quantidade no registro 9 - Trailer: {item.QtdRegTipo4}\n");
                count++;
            }
            if (int.Parse(item.QtdRegTipo5!) != reg05)
            {
                ErrosValidacao.Add($"Quantidade de registros '5 - Empregado MT' inválido, quantidade verificada: {reg05}, quantidade no registro 9 - Trailer: {item.QtdRegTipo5}\n");
                count++;
            }

            if (count > 0)
            {
                return true;
            }
        }
        return false;
    }

    private static bool ValidarTipoDados(TrailerAFD1510 trailer, string linha)
    {
        var camposComErro = new List<string>();

        if (!int.TryParse(trailer.Noves, out _))
        {
            camposComErro.Add("Noves");
        }

        if (!int.TryParse(trailer.TpRegistro, out _))
        {
            camposComErro.Add("TpRegistro");
        }

        if (!double.TryParse(trailer.QtdRegTipo2, out _))
        {
            camposComErro.Add("QtdRegTipo2");
        }

        if (!double.TryParse(trailer.QtdRegTipo3, out _))
        {
            camposComErro.Add("QtdRegTipo3");
        }

        if (!double.TryParse(trailer.QtdRegTipo4, out _))
        {
            camposComErro.Add("QtdRegTipo4");
        }

        if (!double.TryParse(trailer.QtdRegTipo5, out _))
        {
            camposComErro.Add("QtdRegTipo5");
        }

        if (camposComErro.Count == 0)
        {
            return true;
        }
        else
        {
            ErrosValidacao.Add($"Erro de tipo de dados nos campos: {string.Join(", ", camposComErro)}\n\tLinha ({LerArquivoAFD.NumeroLinha}): {linha}\n");
            return false;
        }
    }
    #endregion
}
