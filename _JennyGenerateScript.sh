#!/bin/bash
rm -r Generated
dotnet "Jenny\Jenny.Generator.Cli.dll" gen
echo Terminal will close in 5 seconds...
sleep 5