<?php  
class home extends CI_Controller{
    function __construct(){
        parent::__construct();
        $this->load->helper('url');
        $this->load->helper('asset');
    }
    
    public function index()
    {
        $data['page_title'] = 'G-Learning';
        $this->load->view('main_header',$data);
        $this->load->view('login_page');
        $this->load->view('footer');
    }
}
?>