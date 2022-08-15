import {Navigation} from './Navigation'
import {MainBody} from './MainBody'
import {Footer} from './Footer'
import './App.scss';

function App() {
  return (
    <div className='app'>
      <Navigation />
      <MainBody />
      <Footer />
    </div>
  );
}

export default App
