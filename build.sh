#!/bin/bash

cd `dirname $0`

mkdir -p out

mcs -nologo -optimize+ -unsafe- \
	-debug+ \
	-target:library \
	-out:out/saklient.dll \
	-recurse:'src/*.cs' \
	-r:System.Web.Extensions \
	|| exit $?

