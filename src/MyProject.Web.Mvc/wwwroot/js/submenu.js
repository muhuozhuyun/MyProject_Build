new Vue({
    el: "#app",
    data: {
        menues: [],
        subMenues: [],
        selectedSubMenu: {},
        selectedMainMenu: {}
    },
    methods: {
        selectSubMenu: function (menu) {
            this.selectedSubMenu = menu;
            window.setMainFrameSrc(menu.url);
        },
        selectSecondMainMenu: function (menu) {
            this.subMenues = menu.children;
            if (this.subMenues.length > 0) {
                this.selectedSubMenu = this.subMenues[0];
            }
            if (menu.url) {
                window.setMainFrameSrc(menu.url);
            }
            else {
                if (menu.children[0]) {
                    window.setMainFrameSrc(menu.children[0].url);
                }
            }
            this.setHeightCss(this.subMenues);
        },
        selectMainMenu: function (menu) {
            var self = this;
            this.selectedMainMenu = menu;
            this.subMenues = [];
            this.setHeightCss(this.subMenues);
            window.setMainFrameSrc(menu.url);
        },
        go: function (url) {
            setMainFrameSrc(url);
        },
        setHeightCss: function (submenues) {
            if (submenues.length > 0) {
                $("section.content").css("margin-top", "95px");
                $("section.sub-menu").css("margin-top", "-35px");
            }
            else {
                $("section.content").css("margin-top", "60px");
                $("section.sub-menu").css("margin-top", "0px");
            }
        }
    },
    mounted: function () {
        var self = this;
        abp.services.app.permission.getMenues().done(function (res) {
            self.menues = res;
            self.$nextTick(function () {
                $.AdminBSB.leftSideBar.activate();
            })
        });

        //abp.services.app.project.getDefault().done(function (res) {
        //    if (res) {
        //        $("#ProjectName").text(res.systemName);
        //    }
        //    else {
        //        $("#ProjectName").text($.cookie("platform"));
        //    }
        //    $zq.defaultProject = res;
        //});
        //$("#legalName").text($.cookie("platform"));
    }
});