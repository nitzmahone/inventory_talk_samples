# -*- mode: ruby -*-
# vi: set ft=ruby :

Vagrant.configure("2") do |config|
  config.vm.define "win2019-default" do |box|
    box.vm.box = "jborean93/WindowsServer2019"
    box.vm.box_check_update = false
    box.vm.network "private_network", ip: "192.168.33.19"

    box.vm.provider "virtualbox" do |vb|
      vb.memory = "3192"
      vb.cpus = 2
      vb.linked_clone = true
    end
  end
end
