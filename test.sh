#!/bin/bash

cd `dirname $0`
source config.sh
export SACLOUD_TOKEN
export SACLOUD_SECRET
export SACLOUD_ZONE

mcs -nologo -optimize+ -unsafe- \
	-debug+ \
	-target:library \
	-out:out/tests.dll \
	-recurse:'tests/*.cs' \
	-r:out/saklient.dll \
	-r:NUnit.Framework \
	|| exit $?

mono packages/nunit-color-console.0.1.0.0/tools/nunit-color-console.exe out/tests.dll $*
