#!/bin/bash

cd `dirname $0`
NUNIT=./packages/nunit-color-console.0.1.0.0/tools/nunit-color-console.exe

if ! [ -d packages ]; then
	./nuget install
fi

mcs -nologo -optimize+ -unsafe- \
	-debug+ \
	-target:library \
	-out:out/saklient.dll \
	-recurse:'src/*.cs' \
	-r:System.Web.Extensions \
	|| exit $?

mcs -nologo -optimize+ -unsafe- \
	-debug+ \
	-target:library \
	-out:out/tests.dll \
	-recurse:'tests/*.cs' \
	-r:out/saklient.dll \
	-r:NUnit.Framework \
	|| exit $?
mono $NUNIT out/tests.dll
