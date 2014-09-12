#!/bin/bash

cd `dirname $0`

if ! [ -d packages ]; then
	./nuget install
fi

mkdir -p out

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

./test.sh out/tests.dll
