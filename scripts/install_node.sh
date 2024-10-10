#!/bin/bash
if [ "$1" = "" ]; then
  node_version=$(curl https://nodejs.org/en/|grep LTS |grep -Po "v(\d+\.\d+\.\d)"|head -n 1)
else
  node_version=$1
fi

wget https://nodejs.org/dist/$node_version/node-$node_version-linux-x64.tar.xz
apt-get install -y build-essential libkrb5-dev
tar -xf node-$node_version-linux-x64.tar.xz
cd node-$node_version-linux-x64
cp -R bin/* /usr/bin/
cp -R lib/* /usr/lib/
cp -R share/* /usr/share/
cp -R include/* /usr/include/
npm install gulp -g
rm -rf node-$node_version
