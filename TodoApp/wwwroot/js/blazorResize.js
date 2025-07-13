window.blazorResize = {
    getWindowSize: function () {
        return {
            width: window.innerWidth,
            height: window.innerHeight
        };
    },
    registerResizeHandler: function (dotnetHelper) {
        window.onresize = () => {
            dotnetHelper.invokeMethodAsync('OnResize', window.innerWidth, window.innerHeight);
        };
    }
};
