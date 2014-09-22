#!/bin/bash

cd `dirname $0`
source config.sh
export SACLOUD_TOKEN
export SACLOUD_SECRET
export SACLOUD_ZONE

if ! [ -d packages ]; then
	./nuget install
fi
./nuget restore

SHARPSSH=`find packages -name Tamir.SharpSSH.dll`
DIFFIEHELLMAN=`find packages -name DiffieHellman.dll`
MENTALIS_SECURITY=`find packages -name Org.Mentalis.Security.dll`

mcs -nologo -optimize+ -unsafe- \
	-debug+ \
	-target:library \
	-out:out/tests.dll \
	-recurse:'tests/*.cs' \
	-r:out/saklient.dll \
	-r:"$SHARPSSH" \
	-r:"$DIFFIEHELLMAN" \
	-r:"$MENTALIS_SECURITY" \
	-r:NUnit.Framework \
	|| exit $?

cp -f "$SHARPSSH" "$DIFFIEHELLMAN" "$MENTALIS_SECURITY" out/

mono packages/nunit-color-console.0.1.0.0/tools/nunit-color-console.exe out/tests.dll $*
