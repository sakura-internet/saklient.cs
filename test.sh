#!/bin/bash

cd `dirname $0`
source config.sh
export SACLOUD_TOKEN
export SACLOUD_SECRET
export SACLOUD_ZONE

mono packages/nunit-color-console.0.1.0.0/tools/nunit-color-console.exe $*
