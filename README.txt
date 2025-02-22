**Original repository of AASX Server tool - https://github.com/OPCFoundation/UA-.NETStandard-Samples/tree/master/Workshop/Aggregation**

How to use:
1. In `./bin/Release/net6.0/Quickstarts.AggregationServer.Config.xml` set up aggregated OPC UA servers in part **ua:Endpoints**:
```
<ua:ConfiguredEndpoint>
  <ua:Endpoint>
    <EndpointUrl>opc.tcp://host:port</EndpointUrl>
    ... other configuration ...
  </ua:Endpoint>
</ua:ConfiguredEndpoint>
```
2. Start aggregation OPC UA server via `AggregationServer.exe`.
