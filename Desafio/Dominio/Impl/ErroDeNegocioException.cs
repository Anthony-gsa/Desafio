using System;
using System.Runtime.Serialization;

namespace Desafio.Dominio.Impl
{
    [Serializable]
    internal class ErroDeNegocioException : Exception
    {
        private object descricao;

        public ErroDeNegocioException()
        {
        }

        public ErroDeNegocioException(object descricao)
        {
            this.descricao = descricao;
        }

        public ErroDeNegocioException(string message) : base(message)
        {
        }

        public ErroDeNegocioException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ErroDeNegocioException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}