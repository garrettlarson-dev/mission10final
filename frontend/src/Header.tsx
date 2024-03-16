import galaxyballers from './galaxyballers.webp';

function Header(props: any) {
    return (
    <header className='row'>
      <div className="col-4">
        <img src={galaxyballers} alt="logo" className='logo'/>
      </div>
      <div className="col-8 subtitle">
        {props.title}
      </div>
    </header>
  );
  }

export default Header;