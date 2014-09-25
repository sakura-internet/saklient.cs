# SAKURA Internet API Client Library for C&#35;

This library gives you an easy interface to control your resources on
[SAKURA Cloud](https://secure.sakura.ad.jp/cloud/).


## Table of Contents

* [Requirements](#requirements)
* [How to use this library in your project](#how-to-use-this-library-in-your-project)
* [Examples](#examples)
* [Copyright and license](#copyright-and-license)


## Requirements

- [.NET 4.5+](http://www.microsoft.com/ja-jp/net/default.aspx) or [Mono 3.8.0+](http://www.mono-project.com/)
- [NuGet 2.8.1.0+](https://www.nuget.org/)


## How to use this library in your project

### Visual Studio 2013

1. Choose menu > **Project** > **Manage NuGet Packages...**
2. Search **"Saklient"** and install it

### Mono

```bash
cd YOUR/PROJECT/ROOT

# Create packages.config
cat >packages.config <<EOT
<?xml version="1.0" encoding="utf-8"?>
<packages>
  <package id="Saklient" version="0.0.1" />
</packages>
EOT

# Install packages
wget http://nuget.org/nuget.exe
mono nuget.exe install -o packages

# Edit your code
vim YOUR-CODE.cs
```

```csharp
using System;
using Saklient.Cloud;

class Example {
 static void Main(string[] args) {
  
  // authorize
  API api = API.Authorize(token, secret, zone);
  
  // ...
```

```bash
# Add a compiler option reference to saklient.dll
ln -s `find packages -name saklient.dll` ./
mcs ... -r:saklient.dll YOUR-CODE.cs
mono YOUR-CODE.exe
```


## Examples

Code examples are available [here](http://sakura-internet.github.io/saklient.doc/).


## Copyright and license

Copyright (C) 2014 SAKURA Internet, Inc.

This library is freely redistributable under [MIT license](http://www.opensource.org/licenses/mit-license.php).

