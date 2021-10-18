#!/usr/bin/env bash
set -Ceu
#---------------------------------------------------------------------------
# HttpClientで通信できなかった。
# CreatedAt: 2021-10-18
#---------------------------------------------------------------------------
Run() {
	THIS="$(realpath "${BASH_SOURCE:-0}")"; HERE="$(dirname "$THIS")"; PARENT="$(dirname "$HERE")"; THIS_NAME="$(basename "$THIS")"; APP_ROOT="$PARENT";
	cd "$HERE"
#	dotnet new console
#	dotnet run
}
Run "$@"
