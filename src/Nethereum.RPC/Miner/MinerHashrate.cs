using Nethereum.Hex.HexTypes;
using Nethereum.JsonRpc.Client;
using Nethereum.RPC.Infrastructure;

namespace Nethereum.RPC.Miner
{
    /// <Summary>
    ///     Returns the current amount of hashes per second generated by the CPU miner and any other external miners connected
    ///     to the node.
    /// </Summary>
    public class MinerHashrate : GenericRpcRequestResponseHandlerNoParam<HexBigInteger>
    {
        public MinerHashrate(IClient client) : base(client, ApiMethods.miner_hashrate.ToString())
        {
        }
    }
}