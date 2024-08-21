using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;

namespace AppBloodWeb.Application.Filters;

public class ApiExceptionFilter : IExceptionFilter
{
    private readonly ILogger<ApiExceptionFilter> _logger;
    public ApiExceptionFilter(ILogger<ApiExceptionFilter> logger)
    {
        _logger = logger;
    }

    //Este metodo é chamado para tratar casos de exepção quando um metodo na controller for chamado
    public void OnException(ExceptionContext context)
    { 
        // Obter informações detalhadas da exceção
        var exception = context.Exception;
        var exceptionMessage = exception.Message;
        var exceptionStackTrace = exception.StackTrace;

        _logger.LogError(exception, "OCORREU UM ERRO NÃO TRATADO: {Message} - Stack Trace: {StackTrace}", exceptionMessage, exceptionStackTrace);


        // Criar uma resposta detalhada para o cliente (opcional, dependendo das suas necessidades de segurança)
        var errorResponse = new
        {
            Message = "OCORREU UM PROBLEMA AO TRATAR A SUA SOLICITAÇÃO: Status Code 500",
            Details = exceptionMessage, // Pode incluir detalhes da exceção
            StackTrace = exceptionStackTrace // Incluindo o stack trace pode ser útil para depuração
        };


        context.Result = new ObjectResult(errorResponse)
        {
            StatusCode = StatusCodes.Status500InternalServerError,
        };
    }
}
