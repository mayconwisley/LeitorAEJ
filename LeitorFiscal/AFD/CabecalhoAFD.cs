﻿using LeitorFiscal.Model.Util;
using System.ComponentModel.DataAnnotations;

namespace LeitorFiscal.AFD;

public class CabecalhoAFD
{
    [MaxLength(9, ErrorMessage = "O campo Zeros deve ter um comprimento máximo de '9'")]
    [MinLength(9, ErrorMessage = "O campo Zeros deve ter um comprimento minimo de '9'")]
    public string? Zeros { get; set; } /*Tamanho: 9, Posição: 1 a 9, Tipo: numérico*/

    [MaxLength(1, ErrorMessage = "O campo TpRegistro deve ter um comprimento máximo de '1'")]
    [MinLength(1, ErrorMessage = "O campo TpRegistro deve ter um comprimento minimo de '1'")]
    public string? TpRegistro { get; set; }/*Tamanho: 1, Posição: 10 a 10, Tipo: numérico, Dado: = 1*/

    [MaxLength(1, ErrorMessage = "O campo TpIdentEmpregador deve ter um comprimento máximo de '1'")]
    [MinLength(1, ErrorMessage = "O campo TpIdentEmpregador deve ter um comprimento minimo de '1'")]
    public string? TpIdentEmpregador { get; set; } /*Tamanho: 1, Posição: 11 a 11, Tipo: numérico, Dado: = 1-CNPJ ou 2-CPF*/

    [MaxLength(14, ErrorMessage = "O campo CnpjCpf deve ter um comprimento máximo de '14'")]
    [MinLength(14, ErrorMessage = "O campo CnpjCpf deve ter um comprimento minimo de '14'")]
    public string? CnpjCpf { get; set; } /*Tamanho: 14, Posição: 12 a 25, Tipo: numérico*/

    [MaxLength(12, ErrorMessage = "O campo Cei deve ter um comprimento máximo de '12'")]
    [MinLength(12, ErrorMessage = "O campo Cei deve ter um comprimento minimo de '12'")]
    public string? Cei { get; set; } /*Tamanho: 12, Posição: 26 a 37, Tipo: numérico, Não Obrigatório*/

    [MaxLength(14, ErrorMessage = "O campo Cno deve ter um comprimento máximo de '14'")]
    [MinLength(14, ErrorMessage = "O campo Cno deve ter um comprimento minimo de '14'")]
    public string? Cno { get; set; } /*Tamanho: 14, Posição: 26 a 39, Tipo: numérico, Não Obrigatório, Apenas portaria 671*/

    [MaxLength(150, ErrorMessage = "O campo RazaoSocial deve ter um comprimento máximo de '150'")]
    [MinLength(150, ErrorMessage = "O campo RazaoSocial deve ter um comprimento minimo de '150'")]
    public string? RazaoSocial { get; set; } /*Tamanho: 150, Posição: 38 a 187, Tipo: alfanumérico, Posição: 40 a 189 na portaria 671*/

    [MaxLength(17, ErrorMessage = "O campo NumeroFabRep deve ter um comprimento máximo de '17'")]
    [MinLength(17, ErrorMessage = "O campo NumeroFabRep deve ter um comprimento minimo de '17'")]
    public string? NumeroFabRep { get; set; } /*Tamanho: 17, Posição: 188 a 204, Tipo: numérico, Posição: 190 a 206 na portaria 671*/

    [MaxLength(8, ErrorMessage = "O campo DataInicialRegistro deve ter um comprimento máximo de '8'")]
    [MinLength(8, ErrorMessage = "O campo DataInicialRegistro deve ter um comprimento minimo de '8'")]
    public string? DataInicialRegistro { get; set; } /*Tamanho: 8, Posição: 205 a 212, Tipo: numérico, Formato: ddmmaaaa*/

    [MaxLength(8, ErrorMessage = "O campo DataFinalRegistro deve ter um comprimento máximo de '8'")]
    [MinLength(8, ErrorMessage = "O campo DataFinalRegistro deve ter um comprimento minimo de '8'")]
    public string? DataFinalRegistro { get; set; } /*Tamanho: 8, Posição: 213 a 220, Tipo: numérico, Formato: ddmmaaaa*/

    [MaxLength(10, ErrorMessage = "O campo DataInicialRegistro671 deve ter um comprimento máximo de '10'")]
    [MinLength(10, ErrorMessage = "O campo DataInicialRegistro671 deve ter um comprimento minimo de '10'")]
    public string? DataInicialRegistro671 { get; set; } /*Tamanho: 10, Posição: 207 a 216, Tipo: numérico, Formato: AAAA-MM-dd, Apenas portaria 671 */

    [MaxLength(10, ErrorMessage = "O campo DataFinalRegistro671 deve ter um comprimento máximo de '10'")]
    [MinLength(10, ErrorMessage = "O campo DataFinalRegistro671 deve ter um comprimento minimo de '10'")]
    public string? DataFinalRegistro671 { get; set; } /*Tamanho: 10, Posição: 217 a 226, Tipo: numérico, Formato: AAAA-MM-dd, Apenas portaria 671*/

    [MaxLength(8, ErrorMessage = "O campo DataGeracao deve ter um comprimento máximo de '8'")]
    [MinLength(8, ErrorMessage = "O campo DataGeracao deve ter um comprimento minimo de '8'")]
    public string? DataGeracao { get; set; } /*Tamanho: 8, Posição: 221 a 228, Tipo: numérico, Formato: ddmmaaaa*/

    [MaxLength(4, ErrorMessage = "O campo HoraGeracao deve ter um comprimento máximo de '4'")]
    [MinLength(4, ErrorMessage = "O campo HoraGeracao deve ter um comprimento minimo de '4'")]
    public string? HoraGeracao { get; set; } /*Tamanho: 4, Posição: 229 a 232, Tipo: numérico, Formato: hhmm*/

    [MaxLength(24, ErrorMessage = "O campo DataGeracao671 deve ter um comprimento máximo de '24'")]
    [MinLength(24, ErrorMessage = "O campo DataGeracao671 deve ter um comprimento minimo de '24'")]
    public string? DataHoraGeracao671 { get; set; } /*Tamanho: 24, Posição: 227 a 250, Tipo: numérico, Formato: AAAA-MM-ddThh:mm:00ZZZZZ, Apenas portaria 671*/

    [MaxLength(3, ErrorMessage = "O campo VersaoAfd deve ter um comprimento máximo de '3'")]
    [MinLength(3, ErrorMessage = "O campo VersaoAfd deve ter um comprimento minimo de '3'")]
    public string? VersaoAfd { get; set; } /*Tamanho: 3, Posição: 251 a 253, Tipo: numérico, Dado: = 003, Apenas na versão 671*/

    [MaxLength(1, ErrorMessage = "O campo TpIdentFabricante deve ter um comprimento máximo de '1'")]
    [MinLength(1, ErrorMessage = "O campo TpIdentFabricante deve ter um comprimento minimo de '1'")]
    public string? TpIdentFabricante { get; set; } /*Tamanho: 1, Posição: 254 a 254, Tipo: numérico, Dado: = 1-CNPJ ou 2-CPF, Apenas portaria 671*/

    [MaxLength(14, ErrorMessage = "O campo CnpjCpfFabricante deve ter um comprimento máximo de '14'")]
    [MinLength(14, ErrorMessage = "O campo CnpjCpfFabricante deve ter um comprimento minimo de '14'")]
    public string? CnpjCpfFabricante { get; set; } /*Tamanho: 14, Posição: 255 a 268, Tipo: numérico, Apenas portaria 671*/

    [MaxLength(30, ErrorMessage = "O campo ModeloRep deve ter um comprimento máximo de '30'")]
    [MinLength(30, ErrorMessage = "O campo ModeloRep deve ter um comprimento minimo de '30'")]
    public string? ModeloRep { get; set; } /*Tamanho: 30, Posição: 269 a 298, Tipo: numérico, Apenas portaria 671, Apenas para o REP-C*/

    [MaxLength(4, ErrorMessage = "O campo Crc16 deve ter um comprimento máximo de '4'")]
    [MinLength(4, ErrorMessage = "O campo Crc16 deve ter um comprimento minimo de '4'")]
    public string? Crc16 { get; set; } /*Tamanho: 4, Posição: 233 a 236, Tipo: alfanumérico, Posição: 299 a 302 na portaria 671*/

    public static List<CabecalhoAFD> CabecalhoAfdList { get; set; } = new();

    public static List<string> ErrosValidacao { get; set; } = new();

    public static void GetCabecalho(string linhaArquivo, bool portaria595)
    {
        CabecalhoAFD cabecalho;

        int tamanhoLinha = linhaArquivo.Length;

        if (portaria595)
        {
            if (tamanhoLinha != 236)
            {
                ErrosValidacao.Add($"O registro de '1 - Cabeçalho' possui o tamanho de caracteres diferentes que o definido pela a Portaria n.º 595, de 05 de dezembro de 2013: '236'. Tamanho encontrado: {tamanhoLinha}\n");
                return;
            }

            cabecalho = new()
            {
                Zeros = linhaArquivo[..9],
                TpRegistro = linhaArquivo.Substring(9, 1),
                TpIdentEmpregador = linhaArquivo.Substring(10, 1),
                CnpjCpf = linhaArquivo.Substring(11, 14),
                Cei = linhaArquivo.Substring(25, 12),
                RazaoSocial = linhaArquivo.Substring(37, 150),
                NumeroFabRep = linhaArquivo.Substring(187, 17),
                DataInicialRegistro = linhaArquivo.Substring(204, 8),
                DataFinalRegistro = linhaArquivo.Substring(212, 8),
                DataGeracao = linhaArquivo.Substring(220, 8),
                HoraGeracao = linhaArquivo.Substring(228, 4),
                Crc16 = linhaArquivo.Substring(232, 4)
            };
        }
        else
        {
            if (tamanhoLinha != 232)
            {
                ErrosValidacao.Add($"O registro de '1 - Cabeçalho' possui o tamanho de caracteres diferentes que o definido pela a Portaria n.º 1510, de 21 de agosto de 2009: '232'. Tamanho encontrado: {tamanhoLinha}\n");
                return;
            }

            cabecalho = new()
            {
                Zeros = linhaArquivo[..9],
                TpRegistro = linhaArquivo.Substring(9, 1),
                TpIdentEmpregador = linhaArquivo.Substring(10, 1),
                CnpjCpf = linhaArquivo.Substring(11, 14),
                Cei = linhaArquivo.Substring(25, 12),
                RazaoSocial = linhaArquivo.Substring(37, 150),
                NumeroFabRep = linhaArquivo.Substring(187, 17),
                DataInicialRegistro = linhaArquivo.Substring(204, 8),
                DataFinalRegistro = linhaArquivo.Substring(212, 8),
                DataGeracao = linhaArquivo.Substring(220, 8),
                HoraGeracao = linhaArquivo.Substring(228, 4)

            };
        }

        if (ValidacaoTamanhoDado.ValidarTamanho(cabecalho) && ValidarTipoDados(cabecalho))
        {
            if (cabecalho.Zeros != "000000000")
            {
                ErrosValidacao.Add($"O campo 'Zeros' esta com o valor ({cabecalho.Zeros}) inválido, deve ter o valor '000000000'.\n");
                return;
            }


            if (cabecalho.TpRegistro != "1")
            {
                ErrosValidacao.Add($"O campo 'TpRegistro' esta com o valor ({cabecalho.TpRegistro}) inválido, deve ter o valor '1'.\n");
                return;
            }

            CabecalhoAfdList.Add(cabecalho);
        }
        foreach (var item in ValidacaoTamanhoDado.ErrosValidacao)
        {
            ErrosValidacao.Add(item + "\n");
        }


    }
    private static bool ValidarTipoDados(CabecalhoAFD cabecalho1510)
    {

        var camposComErro = new List<string>();

        if (!int.TryParse(cabecalho1510.Zeros, out _))
        {
            camposComErro.Add("Zeros");
        }

        if (!int.TryParse(cabecalho1510.TpRegistro, out _))
        {
            camposComErro.Add("TpRegistro");
        }

        if (!double.TryParse(cabecalho1510.TpIdentEmpregador, out _))
        {
            camposComErro.Add("TpIdentEmpregador");
        }

        if (!double.TryParse(cabecalho1510.CnpjCpf, out _))
        {
            camposComErro.Add("CnpjCpf");
        }

        if (!string.IsNullOrWhiteSpace(cabecalho1510.Cei))
        {
            if (!double.TryParse(cabecalho1510.Cei, out _))
            {
                camposComErro.Add("Cei");
            }

        }

        if (!double.TryParse(cabecalho1510.NumeroFabRep, out _))
        {
            camposComErro.Add("NumeroFabRep");
        }

        if (!double.TryParse(cabecalho1510.DataInicialRegistro, out _))
        {
            camposComErro.Add("DataInicialRegistro");
        }

        if (!double.TryParse(cabecalho1510.DataGeracao, out _))
        {
            camposComErro.Add("DataGeracao");
        }

        if (!double.TryParse(cabecalho1510.HoraGeracao, out _))
        {
            camposComErro.Add("HoraGeracao");
        }

        if (!double.TryParse(cabecalho1510.DataFinalRegistro, out _))
        {
            camposComErro.Add("DataFinalRegistro");
        }

        if (camposComErro.Count == 0)
        {
            return true;
        }
        else
        {
            ErrosValidacao.Add($"Erro de tipo de dados nos campos: {string.Join(", ", camposComErro)}\n");
            return false;
        }
    }
}
