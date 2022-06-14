using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ShopwareSharp.Client
{
    internal class SimpleTokenProvider<TTokenBase>: TokenProvider<TTokenBase> where TTokenBase: TokenBase
    {
        public SimpleTokenProvider(TokenContainer<TTokenBase> tokenContainer) : base(tokenContainer.Tokens)
        { }

        public override ValueTask<TTokenBase> GetAsync(CancellationToken? cancellation = null)
        {
            return ValueTask.FromResult(_tokens.First());
        }
    }
}
