#!/bin/bash
rm ../AssemblyLoadContext/Published/MyPDFLibrary/System.Net.Http.*
dotnet publish -c Debug  -o ../AssemblyLoadContext/Published/MyPDFLibrary
