/*
Copyright 2017 - 2020 Coin Foundry (coinfoundry.org)
Copyright 2020 - 2021 AlphaX Projects (alphax.pro)
Authors: Oliver Weichhold (oliver@weichhold.com)
         Olaf Wasilewski (olaf.wasilewski@gmx.de)

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and
associated documentation files (the "Software"), to deal in the Software without restriction,
including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense,
and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so,
subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial
portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT
LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE
SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
*/

using Alphaxcore.Serialization;
using Newtonsoft.Json;

namespace Alphaxcore.Blockchain.Ethereum.DaemonResponses
{
    public class SyncState
    {
        /// <summary>
        /// The block at which the import started (will only be reset, after the sync reached his head)
        /// </summary>
        [JsonConverter(typeof(HexToIntegralTypeJsonConverter<ulong?>))]
        public ulong StartingBlock { get; set; }

        /// <summary>
        /// The current block, same as eth_blockNumber
        /// </summary>
        [JsonConverter(typeof(HexToIntegralTypeJsonConverter<ulong?>))]
        public ulong CurrentBlock { get; set; }

        /// <summary>
        /// The estimated highest block
        /// </summary>
        [JsonConverter(typeof(HexToIntegralTypeJsonConverter<ulong?>))]
        public ulong HighestBlock { get; set; }

        /// <summary>
        /// Parity: Total amount of snapshot chunks
        /// </summary>
        [JsonConverter(typeof(HexToIntegralTypeJsonConverter<ulong?>))]
        public ulong WarpChunksAmount { get; set; }

        /// <summary>
        /// Parity: Total amount of snapshot chunks
        /// </summary>
        [JsonConverter(typeof(HexToIntegralTypeJsonConverter<ulong?>))]
        public ulong WarpChunksProcessed { get; set; }
    }
}
