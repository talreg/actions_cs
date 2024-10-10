Vagrant.configure("2") do |config|
  config.vm.box = "ubuntu/jammy64"
  config.vm.network "private_network", ip: "192.168.57.10"
  config.vm.network "public_network"
  config.vm.provider "virtualbox" do |vb|  
    # Customize the amount of memory on the VM:
    vb.memory = "2048"
  end
  config.vm.provision "shell", inline: <<-SHELL
    apt-get update
    apt-get install -y build-essential linux-headers-$(uname -r) dkms ruby openjdk-21-jdk dotnet-sdk-8.0
    apt-get dist-upgrade -y
    apt-get autoremove -y
  SHELL
  config.vm.provision "shell", path: "scripts/install_go.sh"
  config.vm.provision "shell", path: "scripts/install_node.sh"
end
