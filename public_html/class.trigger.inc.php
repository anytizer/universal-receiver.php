<?php

class trigger
{
	public function schema($localpath="")
	{
		file_put_contents("trigger-schema.log", $localpath."\r\n", FILE_APPEND);
	}
	
	public function json($localpath="")
	{
		file_put_contents("trigger-jsosn.log", $localpath."\r\n", FILE_APPEND);
	}
	
	public function _strike($type="unknown", $localpath="")
	{
		if(method_exists($this, $type))
		{
			$process = $this->$type(realpath($localpath));
		}
	}
}
