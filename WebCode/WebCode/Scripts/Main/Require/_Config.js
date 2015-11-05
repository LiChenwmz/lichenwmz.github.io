require.config({
    //定义全局路径
    baseUrl: '/Scripts/Main',
    //定义别名
    paths: {
        'jquery': 'jquery-1.10.2.min',
        'bootstrap': 'bootstrap.min',
    },
    //承接关系
    shim: {
        "bootstrap": ["jquery"],
        "//cdnjs.cloudflare.com/ajax/libs/highlight.js/8.8.0/highlight.min.js": ["jquery"],
    }
});