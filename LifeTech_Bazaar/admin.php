<?php 
// +----------------------------------------------------------------------
// | ThinkPHP [ WE CAN DO IT JUST THINK ]
// +----------------------------------------------------------------------
// | Copyright (c)  http://thinkphp.cn All rights reserved.
// +----------------------------------------------------------------------
// | Licensed ( http://www.apache.org/licenses/LICENSE-2.0 )
// +----------------------------------------------------------------------
// | Author: liu21st <liu21st@gmail.com>
// +----------------------------------------------------------------------

// 應用程式入口文件

// 檢測PHP環境
if (version_compare(PHP_VERSION, '5.3.0', '<')) {
	die('require PHP > 5.3.0 !');
}

// 開啟偵錯模式 建議開發階段開啟 部署階段註解或設為false
define('APP_DEBUG', true);
define('BIND_MODULE','Admin');	//綁定預設模組為admin

// 定義應用程式目錄
define('APP_NAME', 'Application');
define('APP_PATH', './Application/');
//define('BASE_PATH', dirname($_SERVER['SCRIPT_NAME']));

// 引入ThinkPHP入口文件
require './ThinkPHP/ThinkPHP.php';
?>